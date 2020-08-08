<template>

  <GenericModal @close="onCloseClick">
    <template v-slot:body>
      <button class="btn btn-default" v-on:click="onYesClick">
        Yes
      </button>
      <button class="btn btn-default" v-on:click="onNoClick">
        No
      </button>
    </template>
  </GenericModal>

</template>


<script>
import GenericModal from "./GenericModal";
export default {
  name: 'YesNoModal',
  components: {GenericModal},
  methods: {
    onYesClick() {
      this.$emit('yesClick');
    },
    onNoClick() {
      this.$emit('noClick');
    },
    onCloseClick() {
      this.$emit('close');
    }
  }

}

</script>
