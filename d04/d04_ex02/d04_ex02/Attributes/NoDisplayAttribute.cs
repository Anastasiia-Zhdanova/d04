namespace d04_ex02.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple = false)  
    ] 
    public class NoDisplayAttribute : System.Attribute
    {
        
    }
}