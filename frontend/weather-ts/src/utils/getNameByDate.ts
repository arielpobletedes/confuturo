function getNameByDate(index: number) {
  const date = new Date();
  date.setDate(date.getDate() - index);
  const outDate = `${date.toLocaleDateString("es-CL", {
    weekday: "long",
  })} ${String(date.getDate()).padStart(2, "0")} de ${date.toLocaleDateString(
    "es-CL",
    {
      month: "long",
    }
  )}`;
  return outDate;
}

export default getNameByDate;
