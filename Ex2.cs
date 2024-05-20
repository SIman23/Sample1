    static string[] FilterShortStrings(string[] strings)
    {
        // Создаем массив такой же длины, как исходный
        string[] result = new string[strings.Length];
        int index = 0;

        // Проходим по всем строкам в исходном массиве
        foreach (string str in strings)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }

