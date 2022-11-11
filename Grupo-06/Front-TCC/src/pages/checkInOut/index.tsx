import { useEffect, useState } from "react";
import { BiLogOut } from "react-icons/bi";
import { HiOutlineLogout } from "react-icons/hi";
import { useNavigate } from "react-router-dom";
import { toast } from "react-toastify";
import styled from "styled-components";
import { ActivitiesCard } from "../../components/ActivitiesCard";
import DefaultButton from "../../components/button";
import Label from "../../components/Label";
import Layout from "../../components/Layout";
import { Loader } from "../../components/loader";
import { checkInOut } from "../../services/checkInOut";
import { CheckType } from "../../services/checkInOut/types";
import { vehicles } from "../../services/vehicles";
import { CarType } from "../../services/vehicles/types";
import { colors } from "../../styles/colors";
import { handleClock, handleMaskMoney, handlePrice } from "../../utils/clock";

interface CheckInOutType {
  id: number;
  model: string;
  label: string;
  type: number;
  owner: string;
  observation: string;
  checkin_at: number;
  checkout_at: number;
  price: number;
}

const CheckInOut = () => {
  const navigate = useNavigate();
  const [loader, setLoader] = useState<boolean>(false);
  const [collection, setCollection] = useState<CheckInOutType[]>([]);

  const handleStart = async () => {
    setLoader(true);
    let arrayCar: CarType[] = [];
    let arrayActivities: CheckType[] = [];

    const fetchGetVehicles = await vehicles.getVehicles();

    if (!fetchGetVehicles) {
      setLoader(false);
      toast.error("Falha ao carregar dados!");
    }

    arrayCar = fetchGetVehicles;

    const fetchGetActivities = await checkInOut.getActivities();

    if (!fetchGetActivities) {
      setLoader(false);
      toast.error("Falha ao carregar dados!");
    }

    arrayActivities = fetchGetActivities;

    const mergedDataIndex = new Map();
    for (const obj of arrayActivities) {
      mergedDataIndex.set(obj.vehicle_id, obj);
    }

    const merged = arrayCar.map((screen) => {
      return Object.assign(screen, mergedDataIndex.get(screen.id) || {});
    });

    setCollection(merged);
    setLoader(false);
  };

  const handleCheckInOut = async (item: CheckInOutType) => {
    setLoader(true);

    if (item.checkin_at) {
      const price = handlePrice(item.checkin_at, item.checkout_at, item.type);

      console.log(price);

      await checkInOut
        .checkOut(item.label, price)
        .then(() => {
          handleStart();
          toast.success(`${item.owner} saiu do estacionamento!`);
          setLoader(false);
        })
        .catch(() => {
          toast.error("Falha ao dar saída no sistema!");
          setLoader(false);
        });
    } else {
      await checkInOut
        .checkIn(item.label)
        .then(() => {
          handleStart();
          toast.success(`${item.owner} entrou no estacionamento!`);
          setLoader(false);
        })
        .catch(() => {
          toast.error("Falha ao dar entrada no sistema!");
          setLoader(false);
        });
    }
  };

  useEffect(() => {
    handleStart();
  }, []);

  return (
    <Layout>
      {loader ? (
        <Loader />
      ) : (
        <>
          <Top>
            <Column>
              <Label size={14}>Total de veículos</Label>
              <Label size={24}>{collection.length}</Label>
            </Column>
            <DefaultButton
              label="Adicionar"
              background={colors.white}
              borderColor={colors.primary}
              color={colors.primary}
              handleClick={() => navigate("/vehicles/create")}
            />
          </Top>
          <CardList>
            {collection.length > 0 &&
              collection.map((item, index) => {
                return (
                  <ActivitiesCard
                    key={index}
                    handleSubmit={() => handleCheckInOut(item)}
                    vehicle={item}
                    iconRight={
                      item.checkin_at ? (
                        <BiLogOut color={item.observation} size={30} />
                      ) : (
                        <HiOutlineLogout color={item.observation} size={30} />
                      )
                    }
                    checkIn={handleClock(item.checkin_at)}
                    checkOut={handleClock(item.checkout_at)}
                    price={handleMaskMoney(
                      handlePrice(item.checkin_at, item.checkout_at, item.type),
                    )}
                    right={item.checkout_at ? false : true}
                  />
                );
              })}
          </CardList>
        </>
      )}
    </Layout>
  );
};

const Top = styled.div`
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
  width: 100%;
  height: auto;
  margin-bottom: 20px;
`;

const Column = styled.div`
  display: flex;
  flex-direction: column;
`;

const CardList = styled.div`
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  align-items: center;
  flex-wrap: wrap;
  row-gap: 10px;
  column-gap: 5px;
  width: 100%;
  height: auto;
`;

export default CheckInOut;
