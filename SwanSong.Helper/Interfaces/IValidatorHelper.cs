using System.Threading.Tasks;

namespace SwanSong.Helper.Interfaces;

public interface IValidatorHelper<T>
{
    Task ValidateAsync(T itemToValidate, string ruleSet);
}