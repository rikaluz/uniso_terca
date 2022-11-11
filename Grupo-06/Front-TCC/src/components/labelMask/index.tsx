import { IMaskInput } from "react-imask";
import styled from "styled-components";
import { colors } from "../../styles/colors";
import { fontConfig, fontSize } from "../../styles/fonts";

interface InputProps {
  width: string;
  label: string;
  onChange: (e: any) => void;
  value: string;
  error?: boolean;
  errorMessage?: string;
  labelColor: string;
}

export const LabelMask = ({
  width,
  label,
  onChange,
  value,
  error,
  errorMessage,
  labelColor,
}: InputProps) => {
  const masks = [{ mask: "aaa0000" }, { mask: "aaa0a00" }];

  return (
    <Container color={labelColor} width={width}>
      <div className="inputGroup">
        <IMaskInput
          mask={masks}
          definitions={{
            "#": /[1-9]/,
          }}
          onAccept={(value: any) =>
            onChange({ target: { name: label, value } })
          }
          maxLength={7}
          value={value}
        />
        <label htmlFor="name">{label}</label>
        {error ? <ErrorLabel>{errorMessage}</ErrorLabel> : null}
      </div>
    </Container>
  );
};

const Container = styled.div<{ width: string; color: string }>`
  width: ${({ width }) => width};
  height: auto;
  .inputGroup {
    font-family: ${fontConfig.roboto};
    margin: 1em 0 1em 0;
    position: relative;
  }

  .inputGroup input {
    font-size: ${fontSize.small}px;
    padding: 0.8em;
    outline: none;
    border: 1px solid ${colors.lineColor};
    background-color: transparent;
    border-radius: 5px;
    width: 100%;
  }

  .inputGroup label {
    font-size: ${fontSize.small}px;
    position: absolute;
    color: ${({ color }) => color};
    left: 0;
    pointer-events: none;
    transition: all 0.3s ease;
    transform: translateY(-50%) scale(0.9);
    margin: 0em;
    margin-left: 0.5em;
    padding: 0.4em;
    background-color: ${colors.white};
  }
  input::-webkit-outer-spin-button,
  input::-webkit-inner-spin-button {
    -webkit-appearance: none;
    margin: 0;
  }

  input[type="number"] {
    -moz-appearance: textfield;
  }
`;

const ErrorLabel = styled.p`
  font-size: ${fontSize.small}px;
  color: ${colors.red};
  margin: 4px 0px 0px 5px;
`;
