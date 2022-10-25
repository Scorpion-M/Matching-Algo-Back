using AutoMapper;
using MatchingAlgo.Data;
using MatchingAlgo.Models.AvaliableDateDTOs;
using MatchingAlgo.Models.DriverDTOs;
using MatchingAlgo.Models.HelperDTOs;
using MatchingAlgo.Models.ShiftDTOs;

namespace MatchingAlgo.Configurations
{
    public class MapperInitilizer:Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Shift, BaseShiftDTO>().ReverseMap();
            CreateMap<Shift, ShiftDTO>().ReverseMap();
            CreateMap<AvailableDate, BaseAvailabeDateDTO>().ReverseMap();
            CreateMap<AvailableDate, AvailableDateDTO>().ReverseMap();
            CreateMap<Driver, BaseDriverDTO>().BeforeMap((d, dDto) => dDto.DriverLatitude = d.DriverLocation.X).BeforeMap(
                (d, dDto) =>  dDto.DriverLongtitude = d.DriverLocation.Y).ReverseMap();
            CreateMap<Driver, DriverDTO>().BeforeMap((d, dDto) => dDto.DriverLatitude = d.DriverLocation.X).BeforeMap(
                (d, dDto) => dDto.DriverLongtitude = d.DriverLocation.Y).ReverseMap();
            CreateMap<Helper, BaseHelperDTO>().BeforeMap((h, hDto) => hDto.HelperLatitude = h.HelperLocation.X).BeforeMap(
                (h, hDto) => hDto.HelperLongtitude = h.HelperLocation.Y).ReverseMap();
            CreateMap<Helper, HelperDTO>().BeforeMap((h, hDto) => hDto.HelperLatitude = h.HelperLocation.X).BeforeMap(
                (h, hDto) => hDto.HelperLongtitude = h.HelperLocation.Y).ReverseMap();
        }
    }
}
