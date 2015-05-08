using AutoMapper;
using BugNET.Models;
using BugNET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugNET_MVC
{
    public class AutoMapperConfig
    {
        public static void CreateMaps()
        {
            Mapper.CreateMap<UserProfile, UserProfileDetailsViewModel>().ReverseMap();
            Mapper.CreateMap<UserProfile, UserProfilePreferencesViewModel>().ReverseMap();
            Mapper.CreateMap<UserProfile, UserProfileNotificationsViewModel>().ReverseMap();
            Mapper.CreateMap<UserProfile, UserProfileViewModel>().ReverseMap();
            //    .ForMember(dest => dest.Details.FirstName, opt => opt.MapFrom(src => src.FirstName))
            //    .ForMember(dest => dest.Details.LastName, opt => opt.MapFrom(src => src.LastName))
            //    .ForMember(dest => dest.Details.DisplayName, opt => opt.MapFrom(src => src.DisplayName))
            //    .ForMember(dest => dest.Preferences.IssuesPageSize, opt => opt.MapFrom(src => src.IssuesPageSize))
            //    .ForMember(dest => dest.Preferences.PreferredLocale, opt => opt.MapFrom(src => src.PreferredLocale))
            //    .ForMember(dest => dest.Notifications.ReceiveEmailNotifications, opt => opt.MapFrom(src => src.ReceiveEmailNotifications));

            //Mapper.CreateMap<ProfileViewModel, UserProfile>()
            //    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Details.FirstName))
            //    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Details.LastName))
            //    .ForMember(dest => dest.DisplayName, opt => opt.MapFrom(src => src.Details.DisplayName))
            //    .ForMember(dest => dest.IssuesPageSize, opt => opt.MapFrom(src => src.Preferences.IssuesPageSize))
            //    .ForMember(dest => dest.PreferredLocale, opt => opt.MapFrom(src => src.Preferences.PreferredLocale))
            //    .ForMember(dest => dest.ReceiveEmailNotifications, opt => opt.MapFrom(src => src.Notifications.ReceiveEmailNotifications));


        }
    }
}