
string GestFomNombre(int[] listeNombre)
{
    string s = "";
    foreach (int n in listeNombre)
    {
        if (n >= -1000 && n <= 1000)
        {
            if (n % 3 == 0 && n % 5 != 0)
            {
                s = s + "Gest, ";
            }
            else if (n % 5 == 0 && n % 3 != 0)
            {
                s = s + "Form, ";
            }
            else if (n % 3 == 0 && n % 5 == 0)
            {
                s = s + "GestForm, ";
            }
            else
            {
                s = s + n.ToString() + ",";
            }
        }
    }
    s = s.Substring(0, s.Length - 1);
    return s;
}

void main()
{
    int[] tab = new int[5] { 1, 5, 15, 89, 50000 };
    Console.WriteLine(GestFomNombre(tab));

}
main();

