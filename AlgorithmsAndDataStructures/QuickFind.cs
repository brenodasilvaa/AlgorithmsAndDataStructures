namespace AlgorithmsAndDataStructures;

public class QuickFind : IUnionFind
{
    private int[] _nodes { get; set; }
    public void Union(int nodeA, int nodeB)
    {
        for (var i = 0; i < _nodes.Length; i++)
        {
            if (i == nodeA) continue;
            
            if (_nodes[i] == _nodes[nodeA])
                _nodes[i] = _nodes[nodeB];
        }

        _nodes[nodeA] = _nodes[nodeB];
    }

    public bool IsConnected(int nodeA, int nodeB)
    {
        return _nodes[nodeA] == _nodes[nodeB];
    }

    public void SetNumberOfNodes(int numberOfNodes)
    {
        _nodes = new int[numberOfNodes];

        for (var i = 0; i < numberOfNodes; i++)
            _nodes[i] = i;
    }
}