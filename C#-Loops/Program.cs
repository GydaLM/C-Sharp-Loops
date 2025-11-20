
ForLoop();
static void ForLoop()
{
    for(int i = 0; i<5; i++)
    {
        //Du kan printe ut variabler med + utenfor "". Da trenger man ikke $ og {}
        Console.WriteLine("Terje er kul. Verdien til i: "+ i);
    }
}

ForEachLoop();
static void ForEachLoop()
{
    string text = "Some text";
    foreach(var letter in text)
    {
        Console.WriteLine(letter);
    }
}

WhileLoop();
static void WhileLoop()
{
    bool condition = true;
    int counter = 1;
    int number = 4;
    while (condition)
    {
        if(counter < 10)
        {
            Console.WriteLine($"Runde nr. {counter}\n" + number);
            counter++;
            number++;
        }
        else
        {
            condition = false;
        }
    }
}