namespace OOP_ecommerce.Interfaces
{
    public interface IPermissions
    {
        void AddPermission(string permission);
        void AddPermission(List<string> permissions);
    }
}
