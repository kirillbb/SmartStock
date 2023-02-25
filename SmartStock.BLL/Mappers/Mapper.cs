namespace SmartStock.BLL.Mappers
{
    public static class Mapper<TSource, TDestination>
    {
        public static TDestination Map(TSource source)
        {
            var destination = Activator.CreateInstance<TDestination>();
            var sourceProperties = typeof(TSource).GetProperties();
            var destinationProperties = typeof(TDestination).GetProperties();

            foreach ( var property in sourceProperties )
            {
                var destinationProperty = destinationProperties.FirstOrDefault(x => x.Name == property.Name && x.PropertyType == property.PropertyType);
                if ( destinationProperty != null )
                {
                    destinationProperty.SetValue(destination, property.GetValue(source));
                }
            }

            return destination;
        }
    }
}