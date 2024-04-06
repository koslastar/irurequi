private static List<string[]> ReadCSV(string filePath)
{
    var resultList = new List<string[]>();

    // Check if the file exists at the given path
    if (!File.Exists(filePath))
    {
        throw new FileNotFoundException("The file was not found.", filePath);
    }

    // Read all lines from the file
    var lines = File.ReadAllLines(filePath);

    // Process each line
    foreach (var line in lines)
    {
        // Skip empty lines
        if (string.IsNullOrWhiteSpace(line)) continue;

        // Split the line by commas and add the resulting array to the list
        var values = line.Split(',');
        resultList.Add(values);
    }

    return resultList;
}
