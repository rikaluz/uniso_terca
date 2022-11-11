import styled from "styled-components";
import { SvgCar } from "../../assets/svgs/car.svg";
import { SvgMotorcycle } from "../../assets/svgs/motorcycle";
import { colors } from "../../styles/colors";
import { Input } from "../Input";

interface CarTypes {
  model: string;
  label: string;
  type: number;
  owner: string;
  observation: string;
}

interface CarProps {
  vehicle: CarTypes;
  handleSubmit: () => void;
  iconRight?: React.ReactNode;
  checkIn?: string | null;
  checkOut?: string | null;
  price?: string;
  right?: boolean;
}

export const ActivitiesCard = ({
  vehicle,
  handleSubmit,
  iconRight,
  checkIn,
  checkOut,
  price,
  right,
}: CarProps) => {
  return (
    <Container>
      {right ? <Delete onClick={handleSubmit}>{iconRight}</Delete> : null}

      {vehicle.type === 1 ? (
        <SvgCar color={vehicle.observation} width="150" height="150" />
      ) : (
        <SvgMotorcycle color={vehicle.observation} width="150" height="150" />
      )}
      <Input
        width="90%"
        labelColor={vehicle.observation}
        readOnly={true}
        defaultValue={vehicle.owner}
        label="Proprietário"
      />
      <Input
        width="90%"
        readOnly={true}
        labelColor={vehicle.observation}
        defaultValue={vehicle.model}
        label="Modelo"
      />
      <Input
        width="90%"
        labelColor={vehicle.observation}
        readOnly={true}
        defaultValue={vehicle.label}
        label="Placa"
      />

      <Input
        width="90%"
        labelColor={vehicle.observation}
        readOnly={true}
        defaultValue={checkIn ? checkIn : "Nenhuma entrada registrada"}
        label="Entrada"
      />

      <Input
        width="90%"
        labelColor={vehicle.observation}
        readOnly={true}
        defaultValue={checkOut ? checkOut : "Nenhuma saída registrada"}
        label="Saída"
      />

      <Input
        width="90%"
        labelColor={vehicle.observation}
        readOnly={true}
        defaultValue={price ? `${price.toString()}` : "R$ 0,00"}
        label="Faturamento"
      />
    </Container>
  );
};

const Container = styled.div`
  width: 300px;
  margin-top: 10px;
  position: relative;
  height: auto;
  min-height: 300px;
  border: 1px solid ${colors.lineColor};
  border-radius: 10px;

  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  transition: 0.5s;

  :hover {
    -webkit-transform: scale(1.05);
    transform: scale(1.05);
    cursor: pointer;
  }
`;

const Delete = styled.div`
  position: absolute;
  right: -10px;
  top: -10px;
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: ${colors.white};
  cursor: pointer;
`;
