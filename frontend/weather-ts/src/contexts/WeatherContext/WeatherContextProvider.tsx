import React, { useState, type ReactNode } from "react";
import WeatherContext from "./index";
import { type WeatherContextType } from "./types";
import type { WeatherList } from "../../type";

type Props = {
  children: ReactNode;
};

export default function WeatherContextProvider({ children }: Props) {
  const [data, setData] = useState<WeatherContextType>();

  const contextValue: WeatherContextType = {
    data,
    setData,
  };

  return (
    <WeatherContext.Provider value={contextValue}>
      {children}
    </WeatherContext.Provider>
  );
}
