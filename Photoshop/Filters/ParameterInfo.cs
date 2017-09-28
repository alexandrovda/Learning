namespace MyPhotoshop.Filters
{
    /// <summary>
    /// Этот класс содержит описание одного параметра фильтра: как он называется, в каких пределах изменяется, и т.д.
    /// Эта информация необходима для настройки графического интерфейса.
    /// </summary>
    public struct ParameterInfo
    {
        public string Name;
        public double DefaultValue;
        public double MinValue;
        public double MaxValue;
        public double Increment;
    }
}
