// Define namespace for entire file
namespace CSC_Assistant.Algo
// using
open CSC_Assistant.Common.DataStructures

// a module is akin to a class
module Algorithms =
    // Notes: 
    // Everything is immutable
    // Everything is an expression

    // for now this is just an enum
    type ItemType = NFT | FT | Ore
    
    // a func called ItemParts that takes 2 args, the return value is automatically inferred
    let ItemParts (itemMap:Map<string, Item>) (itemId:string) = 
        // define immutable var
        let data = itemMap.[itemId].Blob.GameData        
        // a helper func that splits a Resource into a (id, amount) tuple
        let splitLambda = fun (r:Resource) -> r.ItemID, double r.Amount
        // just a normal if-else, `<>` is `!=` in C#
        if data.CraftingResources <> null && data.CraftingResources.Count <> 0 then
            // |> is the pipe operator
            // e.g. `Map.ofSeq` turns a seq into a map. can be used in two ways:
            // 1. `let z = Map.ofSeq someSeq`
            // 2. `let z = someSeq |> Map.ofSeq`
            let craftMap = data.CraftingResources |> Seq.map splitLambda |> Map.ofSeq
            // last line of an expression is an implicit return
            (NFT, craftMap )        
        else if data.RefinedResources  <> null && data.RefinedResources.Count <> 0 then
            let refineMap = data.RefinedResources |> Seq.map splitLambda |> Map.ofSeq
            // last line of an expression is an implicit return
            (FT, refineMap)
        else
            // last line of an expression is an implicit return
            (Ore, Map.empty)    

    let ItemMap (allItems:Item seq) = 
        allItems |> Seq.map (fun i -> i.ItemId, i) |> Map.ofSeq

    let mergeMaps (map1:Map<string,double>) (map2:Map<string,double>) = 
        Seq.concat [Map.toSeq map1;Map.toSeq map2] 
        |> Seq.groupBy (fun p -> fst(p))
        |> Seq.map (fun (k,v) -> k, v |> Seq.map snd |> Seq.sum)
        |> Map.ofSeq

    let mergeMapSeq = Seq.fold (fun s v -> mergeMaps s v) Map.empty


    let DeeperParts (itemMap:Map<string, Item>) (parts:Map<string,double>) =         
        parts |> Map.toSeq |> Seq.map (fun (k, v) -> 
            let (typ, ps) = ItemParts itemMap ("FT:" + k)
            match typ with 
                | Ore -> [(k, v)] |> Map.ofList
                | _ -> ps |> Map.map (fun _ vv -> vv * v)
            )
        |> mergeMapSeq
 
