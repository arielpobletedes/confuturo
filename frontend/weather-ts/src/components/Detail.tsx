import { URL_WEATHER } from "../constants";
import { Geolocation } from "./Geolocation";
import { DetailLocation } from "./DetailLocation";
import { DetailWeather } from "./DetailWeather";
import useWeatherService from "../Services/useWeatherService";

export const Detail: React.FC = () => {
  const resultGeolocation = Geolocation();
  const params = `latitud=${resultGeolocation.location?.latitude}&longitud=${
    resultGeolocation.location?.longitude
  }&dias=${7}`;
  const url = URL_WEATHER + params;
  const error = useWeatherService(url);
  return (
    <>
      <DetailLocation />
      <DetailWeather />
    </>
  );
};
