import getNameByDate from "../utils/getNameByDate";
import { useWeatherContext } from "../hooks/useWeatherContext";

export const DetailWeather: React.FC = () => {
  const { data, setData } = useWeatherContext();
  return (
    <>
      <ul>
        {data?.list?.map((weather, index) => (
          <li>
            <span>{getNameByDate(index)}</span>
            {`${weather.weather[0].main}, ${weather.weather[0].description}`}
          </li>
        ))}
      </ul>
    </>
  );
};
