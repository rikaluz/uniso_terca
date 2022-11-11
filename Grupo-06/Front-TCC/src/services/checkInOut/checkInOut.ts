import api from "../api/api";

const endPoint = "activities";

const getActivities = async () =>
  await api
    .get(`${endPoint}`)
    .then((res: any) => {
      return res.data;
    })
    .catch(() => {
      return false;
    });

const checkIn = async (label: string) => {
  api.post(`${endPoint}/checkin`, {
    label: label,
  });
};

const checkOut = async (label: string, price: number | null) => {
  api.put(`${endPoint}/checkout`, {
    label: label,
    price: price,
  });
};

export const checkInOut = {
  getActivities,
  checkIn,
  checkOut,
};
