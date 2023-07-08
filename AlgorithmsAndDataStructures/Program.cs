//Union Find

using AlgorithmsAndDataStructures;

var data = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Data", "NodesConnection.txt"));

var unionTypes = new List<UnionFindType> { UnionFindType.QuickFind };

foreach (var unionType in unionTypes)
{
    var unionFind = UnionFindFactory.GetUnionFindImplementation(unionType);

    foreach (var line in data)
    {
        if (line.Length <= 2)
            unionFind.SetNumberOfNodes(int.Parse(line));
        else
        {
            var nodeA = int.Parse(line[..2]);
            var nodeB = int.Parse(line.Substring(2, 1));

            if (unionFind.IsConnected(nodeA, nodeB)) return;
            
            unionFind.Union(nodeA, nodeB);
        }
    }
}

