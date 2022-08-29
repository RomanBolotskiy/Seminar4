
void RandArray()
{
    int[] arr = new int [8];

    for(int i = 0; i<0; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    for(int i = 0; i<8; i++)
    {
        Console.Write("{0} ", arr[i]);
    }
}

RandArray();

