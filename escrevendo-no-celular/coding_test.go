package main

import (
	"testing"
)

func textoParaNumero(t string) string {
	// fmt.Printf("Recebido > %s \n", t)

	if len(t) == 0 {
		return ""
	}

	r := ""
	p := t[:1]

	switch p {
	case " ":
		r = "0"
	case "A":
		r = "2"
	case "B":
		r = "22"
	case "C":
		r = "222"
	case "D":
		r = "3"
	case "E":
		r = "33"
	}

	// fmt.Printf("Numero gerado %s \n", r)

	if len(t) > 1 {
		n := textoParaNumero(t[1:])
		if r[len(r)-1:] == n[:1] {
			return r + "_" + n
		}

		return r + n
	}

	return r
}

func Test_espaco_deve_retornar_com_sucesso(t *testing.T) {
	if r := textoParaNumero(" "); r != "0" {
		t.Error("Espaco nao esta retornando 0")
	}
}

func Test_A_deve_retornar_sucesso(t *testing.T) {
	if r := textoParaNumero("A"); r != "2" {
		t.Error("Letra A nao esta retornando 2")
	}
}

func Test_B_deve_retornar_sucesso(t *testing.T) {
	if r := textoParaNumero("B"); r != "22" {
		t.Error("Letra B nao esta retornando 22")
	}
}

func Test_C_deve_retornar_sucesso(t *testing.T) {
	if r := textoParaNumero("C"); r != "222" {
		t.Error("Letra C nao esta retornando 222")
	}
}

func Test_D_deve_retornar_sucesso(t *testing.T) {
	if r := textoParaNumero("D"); r != "3" {
		t.Error("Letra D nao esta retornando 3")
	}
}

func Test_E_deve_retornar_sucesso(t *testing.T) {
	if r := textoParaNumero("E"); r != "33" {
		t.Error("Letra E nao esta retornando 33")
	}
}

func Test_AD_deve_retornar_sucesso_23(t *testing.T) {
	if r := textoParaNumero("AD"); r != "23" {
		t.Error("Frase AD nao esta retornando 23")
	}
}

func Test_ABC_deve_retornar_sucesso(t *testing.T) {
	if r := textoParaNumero("ABC"); r != "2_22_222" {
		t.Error("Frase ABC nao esta retornando 2_22_222", r)
	}
}

func Test_ABD_deve_retornar_sucesso(t *testing.T) {
	if r := textoParaNumero("ABD"); r != "2_223" {
		t.Error("Frase ABD nao esta retornando 2_223", r)
	}
}

func Test_CCE_deve_retornar_sucesso(t *testing.T) {
	if r := textoParaNumero("CCE"); r != "222_22233" {
		t.Error("Frase CCE nao esta retornando 222_22233", r)
	}
}

func Test_A_espacoB_deve_retornar_sucesso(t *testing.T) {
	if r := textoParaNumero("A B"); r != "2022" {
		t.Error("Frase 'A B' nao esta retornando 2022", r)
	}
}
