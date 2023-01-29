

Console.WriteLine(IsPalindrome2(121));

//solution by using string
bool IsPalindrome(int x)
{
    var strNum = x.ToString();
    var strNumCharArr = strNum.ToCharArray();

    Array.Reverse(strNumCharArr);
    return strNum.Equals(new String(strNumCharArr));
}

bool IsPalindrome2(int x)
{
    var strNum = x.ToString().Reverse();
    return String.Concat(strNum) == x.ToString();

}



