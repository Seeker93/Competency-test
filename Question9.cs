using System;

public class Question9
{
	public String isValidIp(String ipAddress)
	{
        try
        {
            if(ipAddress == null || ipAddress.Length == 0) // Invalid if there is no input
            {
                return "Invalid";
            }
            if (ipAddress.EndsWith(".")) // Invalid if there the address ends in a .
            {
                System.Console.WriteLine(2);
                return "Invalid";
            }

            String[] sections = ipAddress.Split(".");
            if(sections.Length !=4)  // Must be 4 parts  
            {
                return "Invalid";
            }

            foreach( String s in sections)
            {
                int sectionNum = Int32.Parse(s);
                if( sectionNum < 0 || sectionNum > 255)  // Invalid if the number is not between 0 and 255
                {
                    return "Invalid";
                }
            }
      
            return "Valid";  // Only valid if it passes all the other checks

        }
        catch (FormatException)
        {
            System.Console.WriteLine(5);
            return "Invalid";
        }
	}
}
