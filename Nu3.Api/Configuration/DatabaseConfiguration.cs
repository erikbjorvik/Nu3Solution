namespace Nu3.Configuration
{
    public class DatabaseConfiguration
    {
        public static readonly string DBConnectionString = "mongodb://nu3:password@ds155218.mlab.com:55218/nu3";

        public static readonly string DBName = "nu3";
        
        public static readonly string UsersEntity = "users";
        
        public static readonly string BeaconsEntity = "beacons";
        
        public static readonly string IntakeEntity = "intakes";
        
        public static readonly string ConsumableEntity = "consumables";
    }
}