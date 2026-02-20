namespace myApp.Data
{
    public static class UserSession
    {
        public static int UserId { get; set; } = -1; // Значение по умолчанию, -1 значит, что пользователь не авторизован
        public static int RoleId { get; set; } = -1; // Значение по умолчанию, -1 значит, что пользователь не авторизован

    }
}
