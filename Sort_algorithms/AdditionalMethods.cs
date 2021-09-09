namespace Sort_algorithms
{
    public static class AdditionalMethods
    {
        public static void Swap<T>(T[] array, int num1, int num2)
        {
            T temp = array[num1];
            array[num1] = array[num2];
            array[num2] = temp;
        }
    }
}