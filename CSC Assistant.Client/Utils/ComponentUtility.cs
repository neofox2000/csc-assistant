using System.Windows.Forms;

namespace CSC_Assistant.Client.Utils
{
    public static class ComponentUtility
    {
        public static void SetTreeViewRootNode(TreeView treeView, TreeNode rootNode, bool expandRoot = true)
        {
            treeView.Nodes.Clear();
            rootNode.Expand();
            treeView.Nodes.Add(rootNode);
        }
    }
}