using System.Reflection;

static class Instancer
{
    public static T CreateNewInstance<T>() => (T)CreateNewInstance(typeof(T));
    public static object CreateNewInstance(Type type) => CreateNewInstance(type.GetConstructors().First());
    public static object CreateNewInstance(ConstructorInfo ctor) => ctor.Invoke(Enumerable.Repeat<object>(null!, ctor.GetParameters().Length).ToArray());
}