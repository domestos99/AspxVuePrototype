<template>

  <div id="DefaultPage">

    <h1>Default page - Vue.JS</h1>

    <FullNameEditor v-model="fullName"></FullNameEditor>

    <RefreshButton></RefreshButton>
  </div>

</template>


<script>

// import FullNameEditor from "../components/FullNameEditor";

import RefreshButton from "../components/refresh-button/RefreshButton";
import FullNameEditor from "../components/FullNameEditor";

export default {
  name: 'DefaultPage',
  components: {
    FullNameEditor,
    RefreshButton
  },
  props: {
    msg: String
  },
  data() {
    return {
      fullName: 'Riki Fridrich'
    }
  }
};

</script>
