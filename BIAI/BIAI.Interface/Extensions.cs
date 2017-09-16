namespace BIAI.Interface
{
    public static class Extensions
    {
        public static T[] Initialize<T>(this T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = value;
            return array;
        }

        public static T Convert<T>(this object @object)
        {
            return (T)System.Convert.ChangeType(@object, typeof(T));
        }
    }
}
