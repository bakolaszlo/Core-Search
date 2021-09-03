<template>
  <div class="header-container">
    <a
      href="https://mail.google.com"
      class="header-links"
      style="padding: 0 0 0 15px;"
    >
      Gmail
    </a>
    <a
      href="https://www.google.ro/imghp?hl=en"
      class="header-links"
      style="padding: 0 15px 0 15px;"
    >
      Images
    </a>
    <a href="#" class="apps" aria-label="Google apps" aria-expanded="false">
      <svg focusable="false" viewBox="0 0 24 24">
        <path
          d="M6,8c1.1,0 2,-0.9 2,-2s-0.9,-2 -2,-2 -2,0.9 -2,2 0.9,2 2,2zM12,20c1.1,0 2,-0.9 2,-2s-0.9,-2 -2,-2 -2,0.9 -2,2 0.9,2 2,2zM6,20c1.1,0 2,-0.9 2,-2s-0.9,-2 -2,-2 -2,0.9 -2,2 0.9,2 2,2zM6,14c1.1,0 2,-0.9 2,-2s-0.9,-2 -2,-2 -2,0.9 -2,2 0.9,2 2,2zM12,14c1.1,0 2,-0.9 2,-2s-0.9,-2 -2,-2 -2,0.9 -2,2 0.9,2 2,2zM16,6c0,1.1 0.9,2 2,2s2,-0.9 2,-2 -0.9,-2 -2,-2 -2,0.9 -2,2zM12,8c1.1,0 2,-0.9 2,-2s-0.9,-2 -2,-2 -2,0.9 -2,2 0.9,2 2,2zM18,14c1.1,0 2,-0.9 2,-2s-0.9,-2 -2,-2 -2,0.9 -2,2 0.9,2 2,2zM18,20c1.1,0 2,-0.9 2,-2s-0.9,-2 -2,-2 -2,0.9 -2,2 0.9,2 2,2z"
        ></path>
      </svg>
    </a>
    <a href="https://accounts.google.com/servicelogin" class="sign-in"
      >Sign in</a
    >
  </div>
</template>

<script>
export default {
  name: "Header",
};
</script>

<style scoped>
.header-container {
  padding: 10px;
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  justify-content: flex-end;
}

a {
  color: rgba(0, 0, 0, 0.87);
  font-size: 13px;
  font-family: arial, sans-serif;
  text-decoration: none;
}

a:hover {
  text-decoration: underline;
}

.apps {
  display: inline-block;
  border-radius: 2px;
  box-sizing: border-box;
  height: 40px;
  width: 40px;
  padding: 8px;
  color: #000;
  cursor: pointer;
}

.apps:hover {
  background-color: rgba(60, 64, 67, 0.08);
  border-radius: 50%;
}

.apps svg {
  fill: #5f6368;
}

.sign-in {
  font-family: "Google Sans", "Roboto", "RobotoDraft", "Helvetica", Arial,
    sans-serif;
  font-weight: 500;
  font-size: 14px;
  letter-spacing: 0.25px;
  line-height: 16px;
  margin-left: 10px;
  margin-right: 8px;
  text-align: center;
  vertical-align: middle;
  cursor: pointer;
  color: #fff;
  background: #1a73e8;
  margin: 0 8px;
  border: 1px solid transparent;
  padding: 9px 23px;
  border-radius: 4px;

  margin-left: 8px;
}

.sign-in:hover {
  text-decoration: none;
  -webkit-box-shadow: 0 1px 2px 0 rgb(66 133 244 / 30%),
    0 1px 3px 1px rgb(66 133 244 / 15%);
  box-shadow: 0 1px 2px 0 rgb(66 133 244 / 30%),
    0 1px 3px 1px rgb(66 133 244 / 15%);
  background: #2b7de9;
}
</style>
