//Union Find

using AlgorithmsAndDataStructures;

var data = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Data", "NodesConnection.txt"));

var unionTypes = new List<UnionFindType> { UnionFindType.QuickFind, UnionFindType.QuickUnion };

foreach (var unionType in unionTypes)
{
    var unionFind = UnionFindFactory.GetUnionFindImplementation(unionType);

    foreach (var line in data)
    {
        if (line.Length <= 3)
            unionFind.SetNumberOfNodes(int.Parse(line));
        else
        {
            var nodeA = int.Parse(line[..4]);
            var nodeB = int.Parse(line.Substring(4, 4));

            if (unionFind.IsConnected(nodeA, nodeB)) continue;
            
            unionFind.Union(nodeA, nodeB);
        }
    }
}

