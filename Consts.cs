namespace language_cli
{
    public static class Consts
    {
        public const string TURENG_URL = "https://tureng.com/tr/turkce-ingilizcee/";
        public const string TABLE_SELECTOR = "/html/body/div[5]/div/div[1]/table[1]";
        public const string FIRST_ROW = "/html/body/div[5]/div/div[1]/table[1]/tr[4]/td[4]/a";
        public const string FIRST_PART = "/html/body/div[5]/div/div[1]/table[1]/tr[";
        public const string SECOND_PART = "]/td[4]/a";
        public const int COUNT_OF_WORD = 15; 


        // /html/body/div[5]/div/div[1]/table[1]/tr[4]/td[4]/a  <-- FULL XPATH of first word

        // Xpath that above is to access data on site 
        // There are 2 tables. First is about words, second is about patterns.
        // So i selected first table and fourth row inside this table.
        // Because first 3 rows are about columns header, mobile view etc.
        // 
        // I defined table selector too. 
        // Probably we wrote word wrong if i couldnt find any table inside of html
        // I have an idea for this side. Maybe i develop it later.





    }
}
