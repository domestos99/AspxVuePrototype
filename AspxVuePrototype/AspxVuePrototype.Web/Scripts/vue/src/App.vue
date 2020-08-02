<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png">
    <HelloWorld msg="Welcome to Your Vue.js App"/>

    <FullNameEditor v-model="fullName"></FullNameEditor>
    <RefreshButton></RefreshButton>

  </div>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'
import FullNameEditor from "./components/FullNameEditor";
import RefreshButton from "./components/refresh-button/RefreshButton";

export default {
  name: 'App',
  components: {
    HelloWorld,
    FullNameEditor,
    RefreshButton
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
