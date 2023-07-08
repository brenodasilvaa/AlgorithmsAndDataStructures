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
                return new QuickUnion();
            case UnionFindType.QuickUnionWheited:
                return new QuickUnionWheited();
            default:
                return default;
        }
    }
}