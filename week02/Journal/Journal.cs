using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._bestMoment}|{entry._promptText}|{entry._entryText}");
            }
            writer.Close();
        }
    }
    public void LoadFromFile()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        _entries.Clear();

        StreamReader reader = new StreamReader(filename);

        string line;

        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine($"Reading line: {line}");

            string[] parts = line.Split("|");

            Entry newEntry = new Entry();

            newEntry._date = parts[0];
            newEntry._bestMoment = parts[1];
            newEntry._promptText = parts[2];
            newEntry._entryText = parts[3];

            _entries.Add(newEntry);
        }

        reader.Close();
    }

}