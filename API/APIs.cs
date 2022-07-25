public static class APIs
{
    public static void Init(ref WebApplication app,List<Type> APIs)
    {
        var args= new []{app};
        foreach(var type in APIs)
            Activator.CreateInstance(type, args);
    }
}