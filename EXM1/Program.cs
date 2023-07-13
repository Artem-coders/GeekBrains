// Вид 4
string Method4(int count, string text)
{
    string result = "";
    for(int i = 0; i < count; i++ )
    {
        result += text;
    }
    return result;
}
string res = Method4(10, "z");
Console.Write(res);

//цикл в цикле
