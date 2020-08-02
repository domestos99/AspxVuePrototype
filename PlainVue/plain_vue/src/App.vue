<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png">
    <HelloWorld msg="Welcome to Your Vue.js App"/>


    <FullNameEditor v-model="fullName"/>

  </div>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'
import FullNameEditor from "./components/FullNameEditor";

export default {
  name: 'App',
  components: {
    HelloWorld,
    FullNameEditor
  },
  data() {
    return {
      fullName: 'Riki Fridrich'
    }
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
