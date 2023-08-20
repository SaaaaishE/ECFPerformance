namespace ECFPerformance.Constants
{
    public static class ApplicationUserConstants
    {
        public const int PasswordMaxLength = 100;
        public const int PasswordMinLength = 6;

        public const int FirstNameMaxLength = 30;
        public const int FirstNameMinLength = 1;

        public const int LastNameMaxLength = 30;
        public const int LastNameMinLength = 1;

        public const int PhoneNumberMaxLength = 15;
        public const int PhoneNumberMinLength = 10;
    }

    public static class Category
    {
        public const int CategoryNameMinLength = 2;
        public const int CategoryNameMaxLength = 50;
    }

    public static class ProductConstants
    {
        public const int NameMinLength = 2;
        public const int NameMaxLength = 70;

        public const int MakeMinLength = 2;
        public const int MakeMaxLength = 70;
    }

    public static class OrderConstants
    {
        public const int DescrMinLength = 10;
        public const int DescrMaxLength = 2500;
    }

    public static class ProjectCarConstants
    {
        public const int NameMinLength = 4;
        public const int NameMaxLength = 70;

        public const int DescrMinLength = 10;
        public const int DescrMaxLength = 2500;
    }
}