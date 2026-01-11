namespace spamc
{

public class FisherYates<T>(T[] array)
{

    public void Shuffle()
    {
        Random rng = new Random();
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = rng.Next(0, i + 1); // random index between 0 and i (inclusive)

            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
    }
}
    
}
}
