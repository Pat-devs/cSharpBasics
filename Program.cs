DateTime now = DateTime.Now;

int day = now.Day;
int month = now.Month;
int year = now.Year;
int hour = now.Hour;
int minute = now.Minute;
int second = now.Second;

Console.WriteLine(
    "Day: " + day + 
    "month: " + month + 
    "year: " + year + 
    "hour: " + hour + 
    "minutes: " + minute + 
    "seconds: " + second
);