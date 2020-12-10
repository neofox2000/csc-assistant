namespace CSC_Assistant.Algo

open CSC_Assistant.Common.DataStructures

module Algorithms =
    
    type ItemType = NFT | FT | Ore
        
    let ItemParts (itemMap:Map<string, Item>) (itemId:string)  = 
        let data = itemMap.[itemId].Blob.GameData
        if data.CraftingResources <> null && data.CraftingResources.Count <> 0 then
            (NFT, data.CraftingResources |> Seq.map (fun r -> r.ItemID, double r.Amount)|> Map.ofSeq )
        else if data.RefinedResources  <> null && data.RefinedResources.Count <> 0 then
            (FT, data.RefinedResources |> Seq.map (fun r -> r.ItemID, double r.Amount) |> Map.ofSeq )
        else
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
 

    //let rec ItemRaws (itemId:string) (itemMap:Map<string, Item>) = 
    //    let parts = DeeperParts itemId allItems
    //    parts |> Map.toSeq |> Seq.map (fun kvp -> snd(kvp)) |> mergeMapList
    //    |> Map.map (fun k -> fun v -> )
         


    //let FullTree (item:Item) (allItems:Item seq) = 
    //    let blobMap = allItems |> Seq.map (fun i -> i.ItemId, i.Blob) |> Map.ofSeq
    //    let (typ, parts) = ItemParts item
    //    match typ with
    //    | Ore -> []
    //    | _ -> 