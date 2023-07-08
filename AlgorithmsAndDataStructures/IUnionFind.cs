namespace AlgorithmsAndDataStructures;

public interface IUnionFind
{
    void Union(int nodeA, int nodeB);
    bool IsConnected(int nodeA, int nodeB);
    void SetNumberOfNodes(int numberOfNodes);
}