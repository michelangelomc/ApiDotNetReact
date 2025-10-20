using Microsoft.AspNetCore.Identity;

namespace Infrastructure.DataProvider.Servives.DataBaseServices
{
    public class Authenticate : IAuthenticate
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

        public Authenticate(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        public Task<bool> Has_Authenticate(string email, string password)
        {
            Task<SignInResult> result = this.signInManager.PasswordSignInAsync(email, password, false, lockoutOnFailure: false);
            return Task.FromResult(result.Result.Succeeded);
        }

        public async Task LogOut()
        {
            await this.signInManager.SignOutAsync();
        }

        public async Task<bool> RegisterUser(string email, string password)
        {
            IdentityUser userRegister = new() { UserName = email, Email = email };
            
            IdentityResult result = await this.userManager.CreateAsync(userRegister, password);

            if (result.Succeeded)
            {
                await this.signInManager.SignInAsync(userRegister, isPersistent: false);
            }

            return result.Succeeded;
        }
    }
}
