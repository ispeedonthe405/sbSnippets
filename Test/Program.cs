namespace Test
{
    internal class Program
    {

		///////////////////////////////////////////////////////////
		#region INotifyPropertyChanged

		public event PropertyChangedEventHandler? PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected void SetField<TField>(ref TField field, TField value, string propertyName)
		{
			if (EqualityComparer<TField>.Default.Equals(field, value))
			{
				return;
			}

			field = value;
			OnPropertyChanged(propertyName);
		}

		#endregion INotifyPropertyChanged
		///////////////////////////////////////////////////////////





		/////////////////////////////////////////////////////////
		#region something

		#endregion something
		/////////////////////////////////////////////////////////

		int _thing;


        public int thing
        {
            get => _thing;
            set => SetField(ref _thing, value, nameof(thing));
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


			try
			{

			}
			catch (Exception ex)
			{
				sbdotnet.Logger.Error(ex);
			}

		}
    }
}
