using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NArchitecture.Core.Persistence.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BaseDb")));
        services.AddDbMigrationApplier(buildServices => buildServices.GetRequiredService<BaseDbContext>());

        services.AddScoped<IEmailAuthenticatorRepository, EmailAuthenticatorRepository>();
        services.AddScoped<IOperationClaimRepository, OperationClaimRepository>();
        services.AddScoped<IOtpAuthenticatorRepository, OtpAuthenticatorRepository>();
        services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserOperationClaimRepository, UserOperationClaimRepository>();

        services.AddScoped<IMemberRepository, MemberRepository>();
        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IStreetRepository, StreetRepository>();
        services.AddScoped<INeighborhoodRepository, NeighborhoodRepository>();
        services.AddScoped<IDistrictRepository, DistrictRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<IBranchRepository, BranchRepository>();
        services.AddScoped<ILibraryRepository, LibraryRepository>();
        services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
        services.AddScoped<ISocialMediaAccountRepository, SocialMediaAccountRepository>();
        services.AddScoped<IMaterialCopyRepository, MaterialCopyRepository>();
        services.AddScoped<ILocationRepository, LocationRepository>();
        services.AddScoped<IMaterialRepository, MaterialRepository>();
        services.AddScoped<ILocationRepository, LocationRepository>();
        services.AddScoped<IMaterialCopyRepository, MaterialCopyRepository>();
        services.AddScoped<ILocationRepository, LocationRepository>();
        services.AddScoped<IPublisherRepository, PublisherRepository>();
        services.AddScoped<ILanguageRepository, LanguageRepository>();
        services.AddScoped<IAuthorRepository, AuthorRepository>();
        services.AddScoped<ITranslatorRepository, TranslatorRepository>();
        services.AddScoped<IFavoriteListRepository, FavoriteListRepository>();
        services.AddScoped<INotificationRepository, NotificationRepository>();
        services.AddScoped<INotificationRepository, NotificationRepository>();
        services.AddScoped<IBorrowedMaterialRepository, BorrowedMaterialRepository>();
        services.AddScoped<IMaterialRepository, MaterialRepository>();
        services.AddScoped<IMaterialCopyRepository, MaterialCopyRepository>();
        services.AddScoped<IMemberRepository, MemberRepository>();
        services.AddScoped<IPenaltyRepository, PenaltyRepository>();
        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IAuthorRepository, AuthorRepository>();
        services.AddScoped<IBorrowedMaterialRepository, BorrowedMaterialRepository>();
        services.AddScoped<IBranchRepository, BranchRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<IDistrictRepository, DistrictRepository>();
        services.AddScoped<IFavoriteListRepository, FavoriteListRepository>();
        services.AddScoped<ILanguageRepository, LanguageRepository>();
        services.AddScoped<ILibraryRepository, LibraryRepository>();
        services.AddScoped<ILocationRepository, LocationRepository>();
        services.AddScoped<IMaterialRepository, MaterialRepository>();
        services.AddScoped<IMaterialCopyRepository, MaterialCopyRepository>();
        services.AddScoped<IMaterialPropertyRepository, MaterialPropertyRepository>();
        services.AddScoped<IMaterialPropertyValueRepository, MaterialPropertyValueRepository>();
        services.AddScoped<IMaterialTypeRepository, MaterialTypeRepository>();
        services.AddScoped<IMemberRepository, MemberRepository>();
        services.AddScoped<INeighborhoodRepository, NeighborhoodRepository>();
        services.AddScoped<INotificationRepository, NotificationRepository>();
        services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
        services.AddScoped<IPenaltyRepository, PenaltyRepository>();
        services.AddScoped<IPublisherRepository, PublisherRepository>();
        services.AddScoped<ISocialMediaAccountRepository, SocialMediaAccountRepository>();
        services.AddScoped<IStreetRepository, StreetRepository>();
        services.AddScoped<ITranslatorRepository, TranslatorRepository>();
        services.AddScoped<IBorrowedMaterialRepository, BorrowedMaterialRepository>();
        services.AddScoped<IBorrowedMaterialRepository, BorrowedMaterialRepository>();
        services.AddScoped<IMaterialCopyRepository, MaterialCopyRepository>();
        services.AddScoped<IMemberRepository, MemberRepository>();
        services.AddScoped<IMemberContactRepository, MemberContactRepository>();
        services.AddScoped<ILibraryRepository, LibraryRepository>();
        return services;
    }
}
