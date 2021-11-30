import React, { Component } from "react";

const { ScrollView, View, StyleSheet, Text } = require("react-native");

export default class projetos extends Component{
  render () {

    return (
      <ScrollView>
        <View style={styles.main}>
          <Text>Roman</Text>
          <View style={styles.campoProj}>
              <View style={styles.PartCima}>
                  <Text>Nome Proj</Text>
                  <View style={styles.tema}>
                    <Text>Tema</Text>
                  </View>
              </View>
              <Text>
              A descrição do projeto pode ser um pouco dura as vezes pr isso precisamos tomar cuidado cocm a dureza braba
              </Text>
              <View style={styles.alinharProf}>
                <Text>
                  Nome do professor
                </Text>
              </View>
          </View>
        </View>
      </ScrollView>
    )
  };

  
}

const styles = StyleSheet.create({
  main: {
   flex: 1,
   backgroundColor: '#ffffff',
 },
 campoProj: {
   borderSize: 2,

 }

})