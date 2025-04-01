class Element
{
    public int Value;

    public Element(int Value)
    {
        this.Value = Value;
    }

}

class Array
{
    public Element[] elements;
    public int index = -1;

    public Array(int size)
    {
        elements = new Element[size];
        for (int i = 0; i < size; i++)
        {
            elements[i] = new Element(0);
        }
    }

    public void Add(Element element)
    {
        Console.WriteLine($"Додано елемент зi значенням: {element.Value}");
        Console.WriteLine("------------------------------");
        index++;
        elements[index] = element;


    }

    public override string ToString()
    {
        string result = "";
        for (int i = 0; i <= index; i++)
        {
            result = (elements[i].Value.ToString());
            
        }
        return result;
    }

    public Array ArrayAdd(Array arr)
    {
        Console.WriteLine("Виконано додавання масивiв");
        Console.WriteLine("------------------------------");
        Array result = new Array(elements.Length);
        result.index = index;
        for (int i = 0; i < result.elements.Length; i++)
        {
            result.elements[i].Value = elements[i].Value + arr.elements[i].Value;
        }
        return result;
    }

    public Array ArraySubstract(Array arr)
    {
        Console.WriteLine("Виконано вiднiмання масивiв");
        Console.WriteLine("------------------------------");
        Array result = new Array(elements.Length);
        result.index = index;
        for (int i = 0; i < result.elements.Length; i++)
        {
            result.elements[i].Value = elements[i].Value - arr.elements[i].Value;
        }
        return result;
    }

    public Array ArrayMult(Array arr)
    {
        Console.WriteLine("Виконано множення масивiв");
        Console.WriteLine("------------------------------");
        Array result = new Array(elements.Length);
        result.index = index;
        for (int i = 0; i < result.elements.Length; i++)
        {
            result.elements[i].Value = elements[i].Value * arr.elements[i].Value;
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        Element el1 = new Element(1);
        Element el2 = new Element(2);
        Element el3 = new Element(3);
        Element el4 = new Element(4);

        Array arr1 = new Array(4);
        Array arr2 = new Array(4);
        arr1.Add(el1);
        arr1.Add(el2);
        arr1.Add(el3);
        arr1.Add(el4);

        Console.WriteLine(arr1.ToString());
        arr2.Add(el1);
        arr2.Add(el2);
        arr2.Add(el3);
        Console.WriteLine(arr2.ToString());

        Array arr3 = arr1.ArrayAdd(arr2);
        Console.WriteLine(arr3.ToString());
        Array arr4 = arr1.ArraySubstract(arr2);
        Console.WriteLine(arr4.ToString());
        Array arr5 = arr1.ArrayMult(arr2);
        Console.WriteLine(arr5.ToString());
    }
}