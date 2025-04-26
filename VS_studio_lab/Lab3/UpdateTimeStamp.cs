using System;

internal class UpdateTimeStamp
{
    public String getDateTime() {
        // Get current timestamp in NPT (Nepal Time)
        TimeZoneInfo nptZone = TimeZoneInfo.FindSystemTimeZoneById("Nepal Standard Time");
        DateTime currentNPTTime = TimeZoneInfo.ConvertTime(DateTime.Now, nptZone);
        string currentTimestamp = currentNPTTime.ToString("DyyyyMMdd-THHmmss");
        return currentTimestamp;
    }

    public void splitting()
    {
        // Array of filenames
        string[] Filenames = {
        "c71d1cd4-252e-48a5-94bf-c71ca7f68e4a_CustomerName.C1.D20230115-T082015",
        "f335d3e8-7ddc-42d2-9dc1-e456c80fd758_CustomerName.C2.D20201015-T120511",
        "f3e26374-fe23-459f-8567-c586715d18ae_CustomerName.C3.D20210414-T111220"
        };

        string[] updatedFilenames = new string[Filenames.Length];

        for (int i = 0; i < Filenames.Length; i++)
        {
            string[] parts_by_dot = Filenames[i].Split('.');
            string timestamp_updated_filename = parts_by_dot[0] + "." + parts_by_dot[1] + "." + getDateTime();
            updatedFilenames[i] = timestamp_updated_filename;   
        }

        // Print updated filenames
        Console.WriteLine("Output of timestamp updated filenames");
        foreach(string updatedFilename in updatedFilenames)
        {
            Console.WriteLine(updatedFilename);
        }
    }
}

