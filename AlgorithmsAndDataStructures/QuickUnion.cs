namespace AlgorithmsAndDataStructures;

public class QuickUnion : IUnionFind
{
    private int[] _nodes { get; set; }
    public void Union(int nodeA, int nodeB)
    {
        var rootA = FindRoot(nodeA);
        var rootB = FindRoot(nodeB);

        _nodes[rootA] = rootB;
    }

    public bool IsConnected(int nodeA, int nodeB)
    {
        var rootA = FindRoot(nodeA);
        var rootB = FindRoot(nodeB);

        return rootA == rootB;
    }

    public void SetNumberOfNodes(int numberOfNodes)
    {
        _nodes = new int[numberOfNodes];

        for (var i = 0; i < numberOfNodes; i++)
            _nodes[i] = i;
    }

    private int FindRoot(int i)
    {
        while (i != _nodes[i]) i = _nodes[i];
        
        return i;
    }
}