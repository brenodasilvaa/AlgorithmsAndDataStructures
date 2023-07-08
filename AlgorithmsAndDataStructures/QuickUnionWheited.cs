namespace AlgorithmsAndDataStructures;

public class QuickUnionWheited : IUnionFind
{
    private int[] _nodes { get; set; }
    private int[] _sizes { get; set; }
    public void Union(int nodeA, int nodeB)
    {
        var rootA = FindRoot(nodeA);
        var rootB = FindRoot(nodeB);

        if (rootA == rootB) return;

        if (_sizes[nodeA] < _sizes[nodeB])
        {
            _nodes[rootA] = rootB;
            _sizes[rootB] += _sizes[rootA];
        }
        else
        {
            _nodes[rootB] = rootA;
            _sizes[rootA] += _sizes[rootB];
        }
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
        _sizes = new int[numberOfNodes];

        for (var i = 0; i < numberOfNodes; i++)
            _nodes[i] = i;
    }

    private int FindRoot(int i)
    {
        while (i != _nodes[i])
        {
            _nodes[i] = _nodes[_nodes[i]];
            i = _nodes[i];
        }
        
        return i;
    }
}