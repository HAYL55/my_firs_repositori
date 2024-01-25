

void BigAddition()
{
    string int1_str = Console.ReadLine();
    string int2_str = Console.ReadLine();

    //string int1_str = "99";
    //string int2_str = "99";

    int foo = 0;
    bool int1Bigger = false;
    bool int2Bigger = false;
    bool notNeed = false;
    int bar = 0;
    int tac = 0;

    List<int> result = new List<int>();

    List<int> int1 = new List<int>();
    List<int> int2 = new List<int>();

    char[] mas_str1 = int1_str.ToArray();
    char[] mas_str2 = int2_str.ToArray();

    for (int i = 0; i < mas_str1.Length; i++)
    {
        int1.Add(mas_str1[i] - '0');
    }

    for (int i = 0; i < mas_str2.Length; i++)
    {
        int2.Add(mas_str2[i] - '0');
    }

    if (int1.Count > int2.Count)
    {
        foo = int1.Count - int2.Count;
        int1Bigger = true;
    }
    else if (int1.Count < int2.Count)
    {
        foo = int2.Count - int1.Count;
        int2Bigger = true;
    }
    else
    {
        foo = int1.Count;
        notNeed = true;
    }

    for (int i = 0; i < foo; i++)
    {
        if (!notNeed)
        {
            if (int1Bigger)
            {
                int2.Insert(0, 0);
            }
            else
            {
                int1.Insert(0, 0);
            }
        }
        else { }
    }

    foo = 0;

    for (int i = int1.Count - 1; i >= -1; i--)
    {
        if (i == -1)
        {
            if (bar == 0) { }
            else
            {
                result.Add(bar);
            }
        }
        else
        {
            foo = int1[i] + int2[i] + bar;
            tac = foo % 10;
            bar = foo / 10;
            result.Add(tac);
            foo = 0;
        }
    }

    for (int i = result.Count - 1; i >= 0; i--)
    {
        Console.Write(result[i]);
    }
}

void BigMultiplu()
{

    int vee_start = 0;
    int vee_end = 0;
    int count = 0;
    int foo = 0;
    int bar = 0;
    int tac = 0;
    int swap = 0;

    List<int> result = new List<int>();

    List<int> ls = new List<int>();

    int horizontal_lenght = 0;
    int vertical_lenght = 0;

    string int1_str = Console.ReadLine();
    string int2_str = Console.ReadLine();

    //string int1_str = "99";
    //string int2_str = "99";


    List<int> int1 = new List<int>();
    List<int> int2 = new List<int>();

    char[] mas_str1 = int1_str.ToArray();
    char[] mas_str2 = int2_str.ToArray();

    for (int i = 0; i < mas_str1.Length; i++)
    {
        int1.Add(mas_str1[i] - '0');
    }

    for (int i = 0; i < mas_str2.Length; i++)
    {
        int2.Add(mas_str2[i] - '0');
    }


    vertical_lenght = mas_str1.Length;
    horizontal_lenght = mas_str1.Length + mas_str2.Length;


    List<List<int>> values = new List<List<int>>();

    for (int i = int1.Count - 1; i >= 0; i--)
    {
        for (int j = int2.Count - 1; j >= -1; j--)
        {
            if (j > -1)
            {
                foo = int1[i] * int2[j] + bar;
                tac = foo % 10;
                bar = foo / 10;
                ls.Add(tac);
                tac = 0;
            }
            else
            {
                ls.Add(bar);
            }
        }
        values.Add(new List<int>());
        for (int k = ls.Count - 1; k >= 0; k--)
        {
            swap = ls[k];
            values[count].Add(swap);
        }
        count++;
        ls.Clear();
        foo = 0;
        bar = 0;
        tac = 0;

    }


    vee_start = vertical_lenght - 1;
    vee_end = 0;

    for (int i = 0; i < vertical_lenght; i++)
    {
        for (int j = 0; j < vee_start; j++)
        {
            values[i].Insert(0, 0);
        }
        vee_start--;
        for (int k = 0; k < vee_end; k++)
        {
            values[i].Add(0);
        }
        vee_end++;
    }


    foo = 0;
    bar = 0;
    tac = 0;

    for (int i = horizontal_lenght - 1; i >= 0; i--)
    {
        for (int j = 0; j < vertical_lenght; j++)
        {
            foo += values[j][i];
        }

        foo += bar;
        bar = 0;

        if (foo < 10)
        {
            result.Add(foo);
            foo = 0;
            continue;
        }
        else
        {
            tac = foo % 10;
            bar = foo / 10;
            result.Add(tac);
            foo = 0;
        }
    }

    Console.WriteLine();

    for (int i = result.Count - 1; i >= 0; i--)
    {
        Console.Write(result[i]);
    }
}

void BigSubtraction()
{
    string int1_str = Console.ReadLine();
    string int2_str = Console.ReadLine();

    //string int1_str = "98743";
    //string int2_str = "34505";

    int foo = 0;
    bool notNeed = false;
    bool int1Bigger = false;
    bool int2Bigger = false;
    bool gonext = false;
    int bar = 0;
    int tac = 0;
    int swap = 0;

    List<int> result = new List<int>();

    List<int> int1 = new List<int>();
    List<int> int2 = new List<int>();

    char[] mas_str1 = int1_str.ToArray();
    char[] mas_str2 = int2_str.ToArray();

    for (int i = 0; i < mas_str1.Length; i++)
    {
        int1.Add(mas_str1[i] - '0');
    }

    for (int i = 0; i < mas_str2.Length; i++)
    {
        int2.Add(mas_str2[i] - '0');
    }


    if (int1.Count > int2.Count)
    {
        foo = int1.Count - int2.Count;
        int1Bigger = true;
    }
    else if (int1.Count < int2.Count)
    {
        foo = int2.Count - int1.Count;
        int2Bigger = true;
    }
    else
    {
        foo = int1.Count;
        notNeed = true;
    }

    for (int i = 0; i < foo; i++)
    {
        if (!notNeed)
        {
            if (int1Bigger)
            {
                int2.Insert(0, 0);
            }
            else
            {
                int1.Insert(0, 0);
            }
        }
        else { }
    }



    for (int i = int1.Count - 1; i >= 0; i--)
    {
        if (tac > 0)
        {
            if (int1[i] == 0)
            {
                int1[i] = 10 - tac;
                tac = 1;
            }
            else
            {
                int1[i] -= tac;
                tac = 0;
            }
        }
        else { }

        if (int1[i] >= int2[i])
        {
            foo = int1[i] - int2[i];
            result.Add(foo);
        }
        else
        {
            tac = 1;
            bar = int1[i] + 10;
            foo = bar - int2[i];
            result.Add(foo);
        }
    }


    Console.WriteLine();

    for (int i = result.Count - 1; i >= 0; i--)
    {
        Console.Write(result[i]);
    }
}

bool comparison()
{
    string int1_str = Console.ReadLine();
    string int2_str = Console.ReadLine();

    //string int1_str = "9999";
    //string int2_str = "9990";

    int foo = 0;
    bool int1Bigger = false;
    bool int2Bigger = false;
    bool notNeed = false;
    int bar = 0;
    int tac = 0;

    //List<int> result1 = new List<int>();

    bool result = false;

    List<int> int1 = new List<int>();
    List<int> int2 = new List<int>();

    char[] mas_str1 = int1_str.ToArray();
    char[] mas_str2 = int2_str.ToArray();

    for (int i = 0; i < mas_str1.Length; i++)
    {
        int1.Add(mas_str1[i] - '0');
    }

    for (int i = 0; i < mas_str2.Length; i++)
    {
        int2.Add(mas_str2[i] - '0');
    }

    if (int1.Count > int2.Count)
    {
        foo = int1.Count - int2.Count;
        int1Bigger = true;
    }
    else if (int1.Count < int2.Count)
    {
        foo = int2.Count - int1.Count;
        int2Bigger = true;
    }
    else
    {
        foo = int1.Count;
        notNeed = true;
    }

    for (int i = 0; i < foo; i++)
    {
        if (!notNeed)
        {
            if (int1Bigger)
            {
                int2.Insert(0, 0);
            }
            else
            {
                int1.Insert(0, 0);
            }
        }
        else { }
    }

    if (int1.Count > int2.Count)
    {
        result = true;
    }
    else if (int1.Count == int2.Count)
    {
        for (int i = 0; i <= int1.Count - 1; i++)
        {
            if (int1[i] > int2[i])
            {
                result = true;
                break;
            }
            else if (int1[i] == int2[i])
            {
                if (i == int1.Count - 1)
                {
                    result = false;
                }
                else { continue; }
            }
            else
            {
                result = false;
                break;
            }
        }
    }
    else
    {
        result = false;
    }

    Console.WriteLine(result);
    return result;
}



string int1_str = Console.ReadLine();
string int2_str = Console.ReadLine();

//string int1_str = "9999";
//string int2_str = "9990";

int foo = 0;
bool int1Bigger = false;
bool int2Bigger = false;
bool notNeed = false;
int bar = 0;
int tac = 0;

//List<int> result1 = new List<int>();

bool result = false;

List<int> int1 = new List<int>();
List<int> int2 = new List<int>();

char[] mas_str1 = int1_str.ToArray();
char[] mas_str2 = int2_str.ToArray();

for (int i = 0; i < mas_str1.Length; i++)
{
    int1.Add(mas_str1[i] - '0');
}

for (int i = 0; i < mas_str2.Length; i++)
{
    int2.Add(mas_str2[i] - '0');
}

