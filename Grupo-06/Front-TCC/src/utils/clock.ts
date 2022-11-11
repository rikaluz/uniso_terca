import moment from "moment";

export const handleClock = (time: number | null) => {
  if (time === null) {
    return undefined;
  }
  var tempTime = moment(time);
  var test = moment.utc(tempTime);
  var hours = moment(test).subtract(3, "h");
  return `${moment.utc(hours).format("HH:mm:ss")}`;
};
export const dataCovert = (tempo: number) => {
  const data = new Date(tempo).getDate();
  return `${data}`;
};

export const handlePrice = (
  checkIn: number | null,
  checkOut: number | null,
  type: number,
) => {
  if (checkIn === null || checkOut === null) {
    return 0;
  }
  var iN = moment(checkIn);
  var ouT = moment(checkOut);

  var duration = moment.duration(ouT.diff(iN));
  var hours = duration.hours();
  var minutes = duration.minutes();

  if (minutes < 15) {
    return null;
  }

  if (hours <= 1) {
    if (type === 1) {
      return 2;
    } else {
      return 1;
    }
  }

  if (type === 1) {
    return hours * 2.5;
  } else {
    return hours * 1.5;
  }
};

export const handleMaskMoney = (value: number | null) => {
  if (value === null) {
    return "Dentro dos 15 minutos";
  }
  return value.toLocaleString("pt-br", {
    style: "currency",
    currency: "BRL",
  });
};
