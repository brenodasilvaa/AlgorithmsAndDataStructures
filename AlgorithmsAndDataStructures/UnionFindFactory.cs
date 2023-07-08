namespace AlgorithmsAndDataStructures;

public static class UnionFindFactory
{
    public static IUnionFind GetUnionFindImplementation(UnionFindType unionFindType)
    {
        switch (unionFindType)
        {
            case UnionFindType.QuickFind:
                return new QuickFind();
            case UnionFindType.QuickUnion:
                return default;
            default:
                return default;
        }
    }
}