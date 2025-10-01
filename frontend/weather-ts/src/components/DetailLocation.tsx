import { useWeatherContext } from "../hooks/useWeatherContext";

export const DetailLocation: React.FC = () => {
  const { data, setData } = useWeatherContext();
  return (
    <>
      <div>Ciudad: {data?.city.name}</div>
      <div>Pais: {data?.city.country}</div>
    </>
  );
};
