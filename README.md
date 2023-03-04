# CMDFun 👨‍💻
Maybe this repository will get a new name. When I started this project, I wanted to get some values from the command-line interface.
Instead this is also a collection of methods. There is most likely two versions of the same method, a collection of "Gist".

Here is an example: Two versions of the same method.  👀
```csharp
        /// <summary>
        /// Converts dash/underscore delimited words into camel casing.
        /// The first word within the output should be capitalized only if the original word was capitalized.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToCamelCase(string str)
        {
            StringBuilder sb = new StringBuilder();
            string tempStr = str;
            char lastChar = 'a';
            foreach (char character in str)
            {
                if (character == '-' || character == '_')
                {

                }
                else
                {
                    if (lastChar == '_' || lastChar == '-')
                    {
                        sb.Append(character.ToString().ToUpper());
                    }
                    else
                    {
                        sb.Append(character);
                    }
                }
                lastChar = character;
            }
            return sb.ToString();
        }
        
        /// <summary>
        /// Same as ToCamelCase, just in one line.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToCamelCase2(string str)
        {
            return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
        }
```

This is how I execute a command through CMD.
The string strCommandToCMD could be something like "netsh wlan show networks".

```csharp
        private void ExecuteCMDCommand(string strCommandToCMD)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(strCommandToCMD);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }
```

# Nice NuGets - NuGet Must Haves

## [Bogus](https://github.com/LinkedInLearning/11-tips-for-dotnet-6-2486135/blob/Tip07/source/DataLib/DataRepository.cs)

### Useful for creating dummy data

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace DataLib {
  public class DataRepository {
    private List<Customer> _customerList;
    public DataRepository() {
     
    }
    public List<Customer> GetCustomerData() {
      _customerList = new List<Customer>();
      _customerList.Add(new Customer { FullName = "Walt Ritscher", EmailAddress = "walt@somewhere.com", Company = "LinkedIn", CustomerSince = DateOnly.FromDateTime(new DateTime(year: 2015, month: 11, day: 30)) });
      _customerList.Add(new Customer { FullName = "Richard Wallace", EmailAddress = "richard@somewhere.com", Company = "Big Star Collectibles", CustomerSince = DateOnly.FromDateTime(new DateTime(year: 2021, month: 4, day: 12)) });
      return _customerList;
    }

    public List<Customer> Customers
    {
      get
      {
        // code to access data in database
        return GetCustomerData();
      }
    }

    public List<Customer> Customers
    {
      get
      {
        var fakerList = new List<Customer>();
        var customerFaker = new Bogus.Faker<DataLib.Customer>();
        customerFaker.RuleFor(x => x.FullName, x => x.Person.FullName);
        customerFaker.RuleFor(x => x.EmailAddress, x => x.Person.Email);
        customerFaker.RuleFor(x => x.Company, x => x.Person.Company.Name);
        customerFaker.RuleFor(x => x.CustomerSince, x => DateOnly.FromDateTime(x.Date.Past(5, DateTime.Now)));
        customerFaker.RuleFor(x => x.Review, x => x.Rant.Review());
        for (int counter = 0; counter < 30; counter++)
        {
          fakerList.Add(customerFaker.Generate());
        }

        return fakerList;
      }
    }

    public List<Song> Songs
    {
      get
      {
        var labelNames = new[] { "Tune Crooners", "Skyheart", "Green Denim Records", "Whispertime Studios" };
        var fakerList = new List<Song>();
        var songFaker = new Bogus.Faker<DataLib.Song>();

        songFaker.RuleFor(x => x.SongTitle, x => x.Lorem.Slug(3));
        songFaker.RuleFor(x => x.Genre, x => x.Music.Genre());
        songFaker.RuleFor(x => x.Artist, x => x.Person.UserName);
        songFaker.RuleFor(x => x.Label, x => x.PickRandom(labelNames));

        for (int counter = 0; counter < 18; counter++)
        {
          fakerList.Add(songFaker.Generate());
        }

        return fakerList;
      }
    }


    public List<Product> Products
    {
      get
      {

        var fakerList = new List<Product>();
        var productFaker = new Bogus.Faker<DataLib.Product>();

        productFaker.RuleFor(x => x.Name, x => x.Commerce.ProductName());
        productFaker.RuleFor(x => x.Color, x => x.Commerce.Color());
        productFaker.RuleFor(x => x.Description, x => x.Commerce.ProductDescription());
        productFaker.RuleFor(x => x.Department, x => x.Commerce.Department());

        for (int counter = 0; counter < 5; counter++)
        {
          fakerList.Add(productFaker.Generate());
        }

        return fakerList;
      }
    }
  }
}
```

## [Humanizer](https://github.com/LinkedInLearning/11-tips-for-dotnet-6-2486135/blob/Tip04/source/TipsConsole/Examples.cs)

### Human-like text

```csharp
using Humanizer;
namespace TipsConsole {
  internal class Examples {
        public void HumanizeTime() {
            var theTime = DateTime.Now;
            Console.WriteLine(theTime.ToShortTimeString());
            Console.WriteLine(theTime.AddMonths(-5).Humanize());
            Console.WriteLine(theTime.AddMinutes(12).Humanize());

            // use the TimeSpan fluent syntax
            TimeSpan weeks = 3.Weeks() + 2.Weeks();
            Console.WriteLine(weeks.Humanize());
            Console.WriteLine(17.Minutes());
        }

        public void HumanizeFileSize() {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Humanizer.Bytes.ByteSize imageSize = (14).Gigabytes();

            Humanizer.Bytes.ByteSize songSize = (2048).Megabytes();

            Console.WriteLine(imageSize.Humanize());
            Console.WriteLine(songSize.Humanize());
        }

        public void CountThings() {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("cards".ToQuantity(6));
            Console.WriteLine("cards".ToQuantity(6, ShowQuantityAs.Words));
            Console.WriteLine("cards".ToQuantity(1));
            Console.WriteLine("women".ToQuantity(3));
            Console.WriteLine("women".ToQuantity(1));

            Console.WriteLine(14576.ToWords());
            Console.WriteLine(35.ToRoman());

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"{counter}, {counter.ToOrdinalWords()}");
            }
            var numbers = Enumerable.Range(20,6);
            Console.WriteLine(numbers.Humanize());
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            // metric values
            Console.WriteLine(.045d.ToMetric());
            Console.WriteLine( 2654d.ToMetric());
        }
    }
}
```


<p align="center">
  <img alt="CMDFun in Action!" src="https://i.imgur.com/zFOCp.png">
</p>

[Join CodeWars with me! 👨‍💻](http://codewars.com/r/hGyTsQ)
<p>
  <img alt="CodeWars Badge" src="https://www.codewars.com/users/Danielkaas94/badges/large">
</p>
