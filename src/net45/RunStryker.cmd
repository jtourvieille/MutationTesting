cd FizzBuzz
cd FizzBuzz.Tests
dotnet stryker --solution-path "../FizzBuzz.sln" --reporters "['ClearText', 'Json', 'Html']"